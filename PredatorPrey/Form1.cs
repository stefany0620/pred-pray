using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;


namespace PredatorPrey
{
    public partial class MainForm : Form
    {
        static Random random = new Random();

        public MainForm form;

        Bitmap drawArea;
        public int DrawAreaWidth { get { return drawArea.Width; } }
        public int DrawAreaHeight { get { return drawArea.Height; } }

        public SeriesCollection SeriesCollection { get; private set; }

        public int width = 50;
        public int height = 50;
        const int cellSize = 10;

        public List<Particle> preys = new List<Particle>();
        public List<Particle> predators = new List<Particle>();
        public List<Particle> foods = new List<Particle>();

        private List<int> preysCounts = new List<int>();
        private List<int> predatorsCounts = new List<int>();
        private List<int> foodsCounts = new List<int>();

        public int[,] particlesArea;
        public int[,] groupsArea;
        public int[,] foodArea;

        int time;

        public MainForm()
        {
            InitializeComponent();

            drawArea = new Bitmap(Width, Height);
            areaBox.Image = drawArea;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Reset();
            Redraw();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (time > 600) return;

            UpdateArea();

            Redraw();

            Refresh();
        }


        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            time = 0;

            particlesArea = new int[width, height];
            groupsArea = new int[width, height];
            foodArea = new int[width, height];

            preys.Clear();
            predators.Clear();
            foods.Clear();

            preysCounts.Clear();
            foodsCounts.Clear();
            predatorsCounts.Clear();

            GeneratePreys((int)preyStartCount.Value);
            GeneratePredators((int)predatorStartCount.Value);
            //GenerateFood((int)foodRespawn.Value);

            InitChart();

            timer.Start();
        }

        public void Redraw()
        {
            Graphics g = Graphics.FromImage(drawArea);

            g.Clear(Color.White);

            foreach (Food food in foods)
                food.Draw(g);

            foreach (Prey prey in preys)
                prey.Draw(g);

            foreach (Predator predator in predators)
                predator.Draw(g);

            DrawGrid(g);

            DrawGoups(g);

            g.Dispose();
        }

        private void DrawGrid(Graphics g)
        {
            for (int x = 0; x <= DrawAreaWidth; x += cellSize)
                g.FillRectangle(Brushes.Gray, x, 0f, 1f, DrawAreaHeight);

            for (int y = 0; y <= DrawAreaHeight; y += cellSize)
                g.FillRectangle(Brushes.Gray, 0f, y, DrawAreaWidth, 1f);
        }

        private void DrawGoups(Graphics g)
        {
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    // Create font and brush.
                    Font drawFont = new Font("Arial", 7);
                    SolidBrush drawBrush = new SolidBrush(Color.Black);

                    // Set format of string.
                    StringFormat stringFormat = new StringFormat();

                    g.DrawString(groupsArea[x, y].ToString(), drawFont, drawBrush, x * cellSize - 1, y * cellSize - 1, stringFormat);
                }
        }

        public void UpdateArea()
        {
            if (!simulateCheckbox.Checked)
                return;

            GenerateFood((int)foodRespawn.Value);

            foreach (Prey prey in preys)
                prey.Step();

            foreach (Predator predator in predators)
                predator.Step();

            ReprodurePreys();

            ReproducePredators();

            ClearParticles();

            preysCounts.Add(preys.Count);
            predatorsCounts.Add(predators.Count);
            foodsCounts.Add(foods.Count);

            time++;

            timeLabel.Text = time.ToString();
            foodsLabel.Text = foods.Count.ToString();
            predatorsLabel.Text = predators.Count.ToString();
            preysLabel.Text = preys.Count.ToString();
        }

        private void ReproducePredators()
        {
            if ((time + 1) % predatorReproduceTime.Value == 0)
            {
                List<Predator> newPredators = new List<Predator>();
                foreach (Predator predator in predators)
                    newPredators.Add((Predator)predator.GenerateDescendant());

                foreach (Predator predator in newPredators)
                    predators.Add(predator);
            }
        }

        private void ReprodurePreys()
        {
            if ((time + 1) % preyReproduceTime.Value == 0)
            {
                List<Prey> newPreys = new List<Prey>();
                foreach (Prey prey in preys)
                    newPreys.Add((Prey)prey.GenerateDescendant());

                foreach (Prey prey in newPreys)
                    preys.Add(prey);
            }
        }

        public bool IsFreeCell(int x, int y, Particle.ParticleType particleType)
        {
            return particlesArea[x, y] == 0 || particlesArea[x, y] == (int)particleType;
        }

        private Vector2 GetPosition(Particle.ParticleType particleType)
        {
            while (true)
            {
                Vector2 pos = new Vector2(random.Next(0, width), random.Next(0, height));
                if (particlesArea[pos.x, pos.y] == 0 || particlesArea[pos.x, pos.y] == (int)particleType)
                    return pos;
            }
        }

        public void GeneratePreys(int count)
        {
            for(int i = 0; i < count; i++)
            {
                Vector2 pos = GetPosition(Particle.ParticleType.Prey);
                preys.Add(new Prey(pos, (int)preyMaxLives.Value, (int)preyMeanLives.Value, (int)preyViewDistance.Value, cellSize, Color.Blue, this));
            }
        }

        public void GeneratePredators(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Vector2 pos = GetPosition(Particle.ParticleType.Predator);
                predators.Add(new Predator(pos, (int)predatorMaxLives.Value, (int)predatorMeanLives.Value, (int)predatorViewDistance.Value, cellSize, Color.Red, this));
            }
        }

        public void GenerateFood(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Vector2 pos = new Vector2(random.Next(0, width), random.Next(0, height));
                if (foodArea[pos.x, pos.y] == 0 || foodArea[pos.x, pos.y] == (int)Particle.ParticleType.Food)
                    foods.Add(new Food(pos, cellSize, Color.Green, this));
            }
        }

        public void ClearParticles()
        {
            for (int i = preys.Count - 1; i >= 0; i--)
            {

                if (preys[i].IsDeath)
                {
                    groupsArea[preys[i].position.x, preys[i].position.y]--;
                    preys[i] = null;
                    preys.RemoveAt(i);
                }
            }

            for (int i = predators.Count - 1; i >= 0; i--)
            {
                if (predators[i].IsDeath)
                {
                    groupsArea[predators[i].position.x, predators[i].position.y]--;
                    predators[i] = null;
                    predators.RemoveAt(i);
                }
            }

            for (int i = foods.Count - 1; i >= 0; i--)
            {
                if (foods[i].IsDeath)
                {
                    groupsArea[foods[i].position.x, foods[i].position.y]--;
                    foods[i] = null;
                    foods.RemoveAt(i);
                }
            }
        }

        public void InitChart()
        {
            chart.AxisY.Clear();
            chart.AxisY.Add(new Axis { MinValue = 0 });

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Питательные вещества",
                    Values = new ChartValues<int> {},
                    PointGeometry = null,
                },
                new LineSeries
                {
                    Title = "Хищники",
                    Values = new ChartValues<int> {},
                    PointGeometry = null,
                    Fill = null,
                    PointForeground = null,
                },
                new LineSeries
                {
                    Title = "Жертвы",
                    Values = new ChartValues<int> {},
                    PointGeometry = null,
                    Fill = null,
                    PointForeground = null,
                }
            };

            chart.Series = SeriesCollection;
        }

        private void updatePlot_Click(object sender, EventArgs e)
        {
            foreach (int count in predatorsCounts)
                SeriesCollection[1].Values.Add(count);

            foreach (int count in preysCounts)
                SeriesCollection[2].Values.Add(count);

            preysCounts.Clear();
            predatorsCounts.Clear();
        }
    }

    public class Particle
    {
        static Random random = new Random();

        public enum ParticleType { Prey = 1, Predator = 2, Food = 3}
        protected ParticleType particleType;

        public Vector2 position;

        protected Vector2[] turns = new Vector2[4] { Vector2.Up, Vector2.Down, Vector2.Right, Vector2.Left };

        protected int currentEnergy;
        protected int maxEnergy;

        protected int currentLives;
        protected int maxLives;

        public bool IsDeath { get { return currentLives <= 0 || currentEnergy <= 0; } }

        protected int visibleDistance;

        protected int size;
        protected Color color;

        protected MainForm form;

        public Particle(Vector2 pos, int maxLives, int lifeTime, int visibleDistance, int size, Color color, MainForm form)
        {
            this.position = pos;

            this.maxEnergy = (int)RandomGaussian(random, maxLives);
            this.currentEnergy = this.maxEnergy;

            this.maxLives = (int)RandomGaussian(random, lifeTime);
            this.currentLives = this.maxLives;

            this.visibleDistance = visibleDistance;

            this.size = size;

            this.color = color;

            this.form = form;

            this.form.groupsArea[position.x, position.y]++;
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(color), position.x * size, position.y * size, size, size);
        }

        public virtual void Step() 
        {
            currentEnergy--;
            currentLives--;
        }

        protected Vector2 GetRandomOffset()
        {
            int[] turnsIndices = Enumerable.Range(0, 4).OrderBy(c => Guid.NewGuid()).ToArray();

            Vector2 offset = Vector2.Zero;

            foreach (int turnIndex in turnsIndices)
            {
                Vector2 turn = turns[turnIndex];

                if (!VerifyBounds(new Vector2(position.x + turn.x, position.y + turn.y), form.width, form.height))
                    continue;

                if (!form.IsFreeCell(position.x + turn.x, position.y + turn.y, particleType));
                    continue;

                offset = turn;
                break;
            }

            return offset;
        }

        protected List<Vector2> GetAvailableTurns(Particle particle)
        {
            List<Vector2> availableTurns = new List<Vector2>();

            foreach (Vector2 turn in turns)
            {
                int posX = turn.x + position.x;
                int posY = turn.y + position.y;

                if (!VerifyBounds(new Vector2(posX, posY), form.width, form.height))
                    continue;

                if (form.IsFreeCell(posX, posY, particleType) || form.particlesArea[posX, posY] == (int)particle.particleType)
                    availableTurns.Add(turn);
            }

            return availableTurns;
        }

        public virtual void Move(Vector2 offset)
        {
            if (form.groupsArea[position.x, position.y] == 1)
                form.particlesArea[position.x, position.y] = 0;
            
            form.groupsArea[position.x, position.y]--;

            position += offset;

            form.particlesArea[position.x, position.y] = (int)particleType;

            form.groupsArea[position.x, position.y]++;
        }

        public bool MoveTo(Particle particle)
        {
            List<Vector2> availableTurns = GetAvailableTurns(particle);

            if (availableTurns.Count == 0) return false;

            Vector2 currentTurn = Vector2.Zero;

            if (position + Vector2.Up == particle.position)
                currentTurn = Vector2.Up;
            else if (position + Vector2.Down == particle.position)
                currentTurn = Vector2.Down;
            else if (position + Vector2.Right == particle.position)
                currentTurn = Vector2.Right;
            else if (position + Vector2.Left == particle.position)
                currentTurn = Vector2.Left;
            else
                foreach (Vector2 turn in availableTurns)
                    if (Vector2.Distance(position + turn, particle.position) <= Vector2.Distance(position + currentTurn, particle.position))
                        currentTurn = turn;

            Move(currentTurn);

            return currentTurn != Vector2.Zero;
        }

        public bool MoveFrom(Particle particle)
        {
            List<Vector2> availableTurns = GetAvailableTurns(particle);

            if (availableTurns.Count == 0) return false;

            Vector2 currentTurn = Vector2.Zero;
            foreach(Vector2 turn in availableTurns)
                if (Vector2.Distance(position + turn, particle.position) >= Vector2.Distance(position + currentTurn, particle.position))
                    currentTurn = turn;

            Move(currentTurn);

            return currentTurn != Vector2.Zero;
        }

        public void RandomMove()
        {
            Move(GetRandomOffset());
        }

        public virtual void Kill()
        {
            currentEnergy = 0;
            currentLives = 0;
        }

        public virtual Particle GenerateDescendant() { return null; }

        public static Particle NearParticle(Particle p, List<Particle> particles)
        {
            double minDistance = double.MaxValue;
            Particle nearParticle = null;

            foreach(Particle particle in particles)
            {
                if (p == particle) continue;

                double distance = Vector2.Distance(p.position, particle.position);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearParticle = particle;
                }
            }

            return nearParticle;
        }

        public static bool VerifyBounds(Vector2 pos, int width, int height)
        {
            return pos.x >= 0 && pos.x < width && pos.y >= 0 && pos.y < height;
        }


        static double RandomGaussian(Random random, double mean, double sigma = 0.33f)
        {
            double u, v, S;

            do
            {
                u = 2.0f * random.NextDouble() - 1.0f;
                v = 2.0f * random.NextDouble() - 1.0f;
                S = u * u + v * v;
            }
            while (S >= 1.0f);

            double std = u * Math.Sqrt(-2.0f * Math.Log(S) / S);

            double value = std * sigma + mean;

            return value;
        }
    }

    public class Prey : Particle
    {
        public Prey(Vector2 pos, int maxLives, int lifeTime, int visibleDistance, int size, Color color, MainForm form) :
            base(pos, maxLives, lifeTime, visibleDistance, size, color, form)
        {
            particleType = ParticleType.Prey;
            this.form.particlesArea[position.x, position.y] = (int)particleType;
        }

        public override void Step()
        {
            base.Step();

            Particle nearPredator = NearParticle(this, form.predators);
            Particle nearFood = NearParticle(this, form.foods);

            bool moved = false;

            if (nearPredator != null && Vector2.Distance(nearPredator.position, position) < visibleDistance)
                moved = MoveFrom(nearPredator);
            else if (nearFood != null)
                moved = MoveTo(nearFood);

            if (!moved)
                RandomMove();

            foreach (Food food in form.foods)
            {
                if (position == food.position)
                {
                    food.Kill();
                    currentEnergy = maxEnergy;
                }
            }
        }

        public override Particle GenerateDescendant()
        {
            Vector2 offset = GetRandomOffset();
            return new Prey(position + offset, maxEnergy, maxLives, visibleDistance, size, color, form);
        }
    }

    public class Predator : Particle
    {
        public Predator(Vector2 pos, int maxLives, int lifeTime, int visibleDistance, int size, Color color, MainForm form) :
            base(pos, maxLives, lifeTime, visibleDistance, size, color, form)
        {
            particleType = ParticleType.Predator;
            this.form.particlesArea[position.x, position.y] = (int)particleType;
        }

        public override void Step()
        {
            base.Step();

            Particle nearPrey = NearParticle(this, form.preys);

            for (int i = 0; i < new Random().Next(1, 3); i++)
            {
                bool moved = false;

                if (nearPrey != null && Vector2.Distance(nearPrey.position, position) < visibleDistance)
                    moved = MoveTo(nearPrey);

                if (!moved)
                    RandomMove();

                foreach (Prey prey in form.preys)
                {
                    if (position == prey.position)
                    {
                        prey.Kill();
                        currentEnergy = maxEnergy;
                        break;
                    }
                }
            }
        }

        public override Particle GenerateDescendant()
        {
            Vector2 offset = GetRandomOffset();
            return new Predator(position + offset, maxEnergy, maxLives, visibleDistance, size, color, form);
        }

        public override void Kill()
        {
            base.Kill();
            form.particlesArea[position.x, position.y] = 0;
        }
    }

    public class Food : Particle
    {
        public Food(Vector2 pos, int size, Color color, MainForm form) :  base(pos, 1, 1, 0, size, color, form)
        {
            particleType = ParticleType.Food;
            this.form.foodArea[position.x, position.y] = (int)particleType;
        }

        public override void Kill()
        {
            base.Kill();
        }
    }

    public class Vector2
    {
        public int x;
        public int y;

        public static Vector2 Zero { get { return new Vector2(0, 0); } }
        public static Vector2 Up { get { return new Vector2(0, -1); } }
        public static Vector2 Down { get { return new Vector2(0, 1); } }
        public static Vector2 Right { get { return new Vector2(1, 0); } }
        public static Vector2 Left { get { return new Vector2(-1, 0); } }

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x + v2.x, v1.y + v2.y);
        }

        public static bool operator !=(Vector2 v1, Vector2 v2)
        {
            return v1.x != v2.x || v1.y != v2.y;
        }

        public static bool operator ==(Vector2 v1, Vector2 v2)
        {
            return v1.x == v2.x && v1.y == v2.y;
        }

        public static double Distance(float x1, float y1, float x2, float y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static double Distance(Vector2 v1, Vector2 v2)
        {
            return Distance(v1.x, v1.y, v2.x, v2.y);
        }
    }
}
