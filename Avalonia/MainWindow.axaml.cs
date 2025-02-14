using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;  // Для работы с ImageBrush
using Avalonia.Media.Imaging;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AvaloniaExample
{
    using System;

    class Program
    { }

    public interface IMlecopitaushee
    {
        void MakeSound(TextBlock _outputTextBlock);
    }

    public class Animal : IMlecopitaushee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void SetName(string name) => Name = name;
        public void SetAge(int age) => Age = age;
        public string GetName() => Name;
        public int GetAge() => Age;

        public virtual void MakeSound(TextBlock _outputTextBlock)
        {
            var random = new Random();
            if (random.Next() % 2 == 0)
                _outputTextBlock.Text = "Makes a sound.";
            else
                _outputTextBlock.Text = "Doesn't make a sound.";
        }
    }

    public interface IHomeAnimal
    {
        int Friendliness { get; }
        int Height { get; }

        void SetFriendliness(int friendliness);
        void SetHeight(int height);
        void Frienship();
    }

    public class HomeAnimal : Animal, IHomeAnimal
    {
        public int Friendliness { get; set; }
        public int Height { get; set; }

        public HomeAnimal(string name, int age, int friendliness, int height)
        : base(name, age)
        {
            // Инициализация
            this.Friendliness = friendliness;
            this.Height = height;
        }

        public void SetFriendliness(int friendliness) => Friendliness = friendliness;
        public void SetHeight(int height) => Height = height;

        public void Frienship()
        {
            Console.WriteLine($"\tThe home animal's friendliness is {Friendliness} out of 10.");
        }

        // Геттеры для Friendliness и Height
        public int GetFriendliness() => Friendliness;
        public int GetHeight() => Height;
        public override void MakeSound(TextBlock _outputTextBlock)
        {
            var random = new Random();
            if (random.Next() % 2 == 0)
                _outputTextBlock.Text = "Makes a sound.";
            else
                _outputTextBlock.Text = "Doesn't make a sound.";
        }
    }

    public interface IWildAnimal
    {
        string FurColor { get; }
        int AverageAge { get; }

        void SetFurColor(string furColor);
        void SetAverageAge(int averageAge);
    }
    public class WildAnimal : Animal, IWildAnimal
    {
        public string FurColor { get; set; }
        public int AverageAge { get; set; }

        public WildAnimal(string name, int age, string furColor, int averageAge) : base(name, age)
        {
            // Инициализация
            FurColor = furColor;
            AverageAge = averageAge;
        }

        public void SetFurColor(string furColor) => FurColor = furColor;
        public void SetAverageAge(int averageAge) => AverageAge = averageAge;

        // Геттеры для FurColor и AverageAge
        public string GetFurColor() => FurColor;
        public int GetAverageAge() => AverageAge;
        public override void MakeSound(TextBlock _outputTextBlock)
        {
            var random = new Random();
            if (random.Next() % 2 == 0)
                _outputTextBlock.Text = "Makes a sound.";
            else
                _outputTextBlock.Text = "Doesn't make a sound.";
        }
    }

    public class Monkey : Animal, IHomeAnimal, IWildAnimal
    {
        // HomeAnimal properties
        public int Friendliness { get; set; }
        public int Height { get; set; }

        // WildAnimal properties
        public string FurColor { get; set; }
        public int AverageAge { get; set; }

        // Monkey-specific properties
        public string FavoriteMeal { get; set; }
        public int Kilograms { get; set; }

        public Monkey(string name, int age, string furColor, int friendliness, int height, int averageAge, string favoriteMeal, int kilograms)
            : base(name, age)
        {
            FurColor = furColor;
            Friendliness = friendliness;
            Height = height;
            AverageAge = averageAge;
            FavoriteMeal = favoriteMeal;
            Kilograms = kilograms;
        }

        // HomeAnimal methods
        public void SetFriendliness(int friendliness) => Friendliness = friendliness;
        public void SetHeight(int height) => Height = height;

        public void Frienship()
        {
            Console.WriteLine($"\tThe monkey's friendliness is {Friendliness} out of 10.");
        }

        // WildAnimal methods
        public void SetFurColor(string furColor) => FurColor = furColor;
        public void SetAverageAge(int averageAge) => AverageAge = averageAge;

        // Monkey-specific methods
        public void SetFavoriteMeal(string favoriteMeal) => FavoriteMeal = favoriteMeal;
        public void SetKilograms(int kilograms) => Kilograms = kilograms;
        public int GetFriendliness() => Friendliness;
        public int GetHeight() => Height;
        public string GetFurColor() => FurColor;
        public int GetAverageAge() => AverageAge;
        public string GetFavoriteMeal() => FavoriteMeal;
        public int GetKilograms() => Kilograms;

        public override void MakeSound(TextBlock _outputTextBlock)
        {
            var random = new Random();
            if (random.Next() % 2 == 0)
                _outputTextBlock.Text = "Makes a sound.";
            else
                _outputTextBlock.Text = "Doesn't make a sound.";
        }
    }

    public partial class MainWindow : Window
    {
        private TextBox _inputTextBox = null!;
        private TextBlock _outputTextBlock = null!;
        private TextBlock _outputTextBlock1 = null!;
        private TextBlock _outputTextBlock2 = null!;
        private TextBlock _outputTextBlock3 = null!;
        private TextBlock _outputTextBlock4 = null!;
        private TextBlock _outputTextBlock5 = null!;
        private TextBlock _outputTextBlock6 = null!;
        private TextBlock _outputTextBlock7 = null!;
        private TextBlock _outputTextBlock8 = null!;
        private TextBlock _outputTextBlock9 = null!;
        private TextBlock _outputTextBlock10 = null!;
        private TextBlock _outputTextBlock11 = null!;
        private TextBlock _outputTextBlock12 = null!;
        private TextBlock _outputTextBlock13 = null!;
        private TextBlock _outputTextBlock14 = null!;
        private TextBlock _outputTextBlock15 = null!;
        private TextBlock _outputTextBlock16 = null!;
        private TextBlock _outputTextBlock17 = null!;
        private TextBlock _outputTextBlock18 = null!;
        private TextBlock _outputTextBlock19 = null!;
        private TextBlock _outputTextBlock20 = null!;
        private TextBlock _outputTextBlock21 = null!;
        private TextBlock _outputTextBlock22 = null!;
        private TextBlock _outputTextBlock23 = null!;
        private TextBlock _outputTextBlock24 = null!;
        private TextBlock _outputTextBlock25 = null!;

        private TextBlock _outputTextBlock26 = null!;
        private TextBlock _outputTextBlock27 = null!;
        private TextBlock _outputTextBlock28 = null!;
        private TextBlock _outputTextBlock29 = null!;
        private TextBlock _outputTextBlock30 = null!;

        private Button fMyVirtualZOO = null!;
        private Button fStart = null!;
        private Button fOurAnimals = null!;
        private Button fAboutproject = null!;
        private Button fexit = null!;
        private Button tStartperent = null!;
        private Button animalsave = null!;
        private Button animalsave1 = null!;
        private Button animalsave2 = null!;
        private Button animalsave3 = null!;
        private Button Back1 = null!;


        private Button Liver1 = null!;
        private Button Liver2 = null!;
        private Button Liver3 = null!;
        private Button Liver4 = null!;

        private TextBox Name = null;
        private TextBox Age = null;
        private TextBox Friend = null;
        private TextBox Height = null;
        private TextBox Fur = null;
        private TextBox Average = null;
        private TextBox Meal = null;
        private TextBox Kilo = null;
        // private Button save = null!;
        Animal myAnimal = new Animal("Cat", 14);
        HomeAnimal myHomeAnimal = new HomeAnimal("Dog", 3, 9, 52);
        WildAnimal myWildAnimal = new WildAnimal("Lion", 5, "Gold", 36);
        Monkey myMonkey = new Monkey("Bobby", 10, "Brown", 7, 45, 15, "Banana", 8);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            // Получаем ссылки на элементы
            fMyVirtualZOO = this.FindControl<Button>("FirstButton");
            fStart = this.FindControl<Button>("SecondButton");
            fOurAnimals = this.FindControl<Button>("OurAnimal");
            fAboutproject = this.FindControl<Button>("Aboutproject");
            fexit = this.FindControl<Button>("Exit");
            tStartperent = this.FindControl<Button>("lab");
            Liver1 = this.FindControl<Button>("liver1");
            Liver2 = this.FindControl<Button>("liver2");
            Liver3 = this.FindControl<Button>("liver3");
            Liver4 = this.FindControl<Button>("liver4");
            _outputTextBlock26 = this.FindControl<TextBlock>("OutputTextBlock26");
            _outputTextBlock27 = this.FindControl<TextBlock>("OutputTextBlock27");
            _outputTextBlock28 = this.FindControl<TextBlock>("OutputTextBlock28");
            _outputTextBlock29 = this.FindControl<TextBlock>("OutputTextBlock29");
            _outputTextBlock30 = this.FindControl<TextBlock>("OutputTextBlock30");
            _inputTextBox = this.FindControl<TextBox>("InputTextBox");
            _outputTextBlock = this.FindControl<TextBlock>("OutputTextBlock");
            _outputTextBlock1 = this.FindControl<TextBlock>("OutputTextBlock1");
            _outputTextBlock2 = this.FindControl<TextBlock>("OutputTextBlock2");
            _outputTextBlock3 = this.FindControl<TextBlock>("OutputTextBlock3");
            _outputTextBlock4 = this.FindControl<TextBlock>("OutputTextBlock4");
            _outputTextBlock5 = this.FindControl<TextBlock>("OutputTextBlock5");
            _outputTextBlock6 = this.FindControl<TextBlock>("OutputTextBlock6");
            _outputTextBlock7 = this.FindControl<TextBlock>("OutputTextBlock7");
            _outputTextBlock8 = this.FindControl<TextBlock>("OutputTextBlock8");
            _outputTextBlock9 = this.FindControl<TextBlock>("OutputTextBlock9");
            _outputTextBlock10 = this.FindControl<TextBlock>("OutputTextBlock10");
            _outputTextBlock11 = this.FindControl<TextBlock>("OutputTextBlock11");
            _outputTextBlock12 = this.FindControl<TextBlock>("OutputTextBlock12");
            _outputTextBlock13 = this.FindControl<TextBlock>("OutputTextBlock13");
            _outputTextBlock14 = this.FindControl<TextBlock>("OutputTextBlock14");
            _outputTextBlock15 = this.FindControl<TextBlock>("OutputTextBlock15");
            _outputTextBlock16 = this.FindControl<TextBlock>("OutputTextBlock16");
            _outputTextBlock17 = this.FindControl<TextBlock>("OutputTextBlock17");
            _outputTextBlock18 = this.FindControl<TextBlock>("OutputTextBlock18");
            _outputTextBlock19 = this.FindControl<TextBlock>("OutputTextBlock19");
            _outputTextBlock20 = this.FindControl<TextBlock>("OutputTextBlock20");
            _outputTextBlock21 = this.FindControl<TextBlock>("OutputTextBlock21");
            _outputTextBlock22 = this.FindControl<TextBlock>("OutputTextBlock22");
            _outputTextBlock23 = this.FindControl<TextBlock>("OutputTextBlock23");
            _outputTextBlock24 = this.FindControl<TextBlock>("OutputTextBlock24");
            _outputTextBlock25 = this.FindControl<TextBlock>("OutputTextBlock25");
            back = this.FindControl<Button>("back");
            Back1 = this.FindControl<Button>("Back");
            Name = this.FindControl<TextBox>("name");
            Age = this.FindControl<TextBox>("age");
            Friend = this.FindControl<TextBox>("friend");
            Height = this.FindControl<TextBox>("height");
            Fur = this.FindControl<TextBox>("fur");
            Average = this.FindControl<TextBox>("average");
            Meal = this.FindControl<TextBox>("meal");
            Kilo = this.FindControl<TextBox>("kilo");
            animalsave = this.FindControl<Button>("asave");
            animalsave1 = this.FindControl<Button>("asave1");
            animalsave2 = this.FindControl<Button>("asave2");
            animalsave3 = this.FindControl<Button>("asave3");

            // Инициализация видимости элементов
            back.IsVisible = false;
            _inputTextBox.IsVisible = false;
            _outputTextBlock.IsVisible = false;
            tStartperent.IsVisible = false;
            Back1.IsVisible = false;
            Liver1.IsVisible = false;
            Liver2.IsVisible = false;
            Liver3.IsVisible = false;
            Liver4.IsVisible = false;
            Name.IsVisible = false;
            Age.IsVisible = false;
            animalsave.IsVisible = false;
            Friend.IsVisible = false;
            Height.IsVisible = false;
            Fur.IsVisible = false;
            Average.IsVisible = false;
            Meal.IsVisible = false;
            Kilo.IsVisible = false;
            animalsave.IsVisible = false;
            animalsave1.IsVisible = false;
            animalsave2.IsVisible = false;
            animalsave3.IsVisible = false;
            // Устанавливаем изображение на фон окна
            this.Background = new ImageBrush
            {
                Source = new Bitmap("/Users/dagosh/Desktop/Снимок экрана 2024-12-13 в 01.09.20.png"),
                Stretch = Stretch.UniformToFill
            };
        }

        private void Exitbotton(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void FormAboutProject(object sender, RoutedEventArgs e)
        {
            _inputTextBox.IsVisible = false;
            _outputTextBlock.IsVisible = false;
            fAboutproject.IsVisible = false;
            fexit.IsVisible = false;
            fMyVirtualZOO.IsVisible = false;
            fOurAnimals.IsVisible = false;
            fStart.IsVisible = false;
            tStartperent.IsVisible = true;
            back.IsVisible = true;
            Liver1.IsVisible = false;
            Liver2.IsVisible = false;
            Liver3.IsVisible = false;
            Liver4.IsVisible = false;
            animalsave.IsVisible = false;
            Friend.IsVisible = false;
            Height.IsVisible = false;
            Fur.IsVisible = false;
            Average.IsVisible = false;
            Meal.IsVisible = false;
            Kilo.IsVisible = false;
            // Устанавливаем изображение на фон
            this.Background = new ImageBrush
            {
                Source = new Bitmap("/Users/dagosh/Desktop/Снимок экрана 2024-12-20 в 11.19.49.png"),
                Stretch = Stretch.UniformToFill
            };

            // Пытаемся найти кнопку с правильным именем
            tStartperent = this.FindControl<Button>("lab");
            back = this.FindControl<Button>("back");
        }

        private void OnBackButtonClick(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
        }

        private void Showall(object sender, RoutedEventArgs e)
        {
            _inputTextBox.IsVisible = false;
            _outputTextBlock.IsVisible = false;
            fAboutproject.IsVisible = false;
            fexit.IsVisible = false;
            fMyVirtualZOO.IsVisible = false;
            fOurAnimals.IsVisible = false;
            fStart.IsVisible = false;
            tStartperent.IsVisible = false;
            Back1.IsVisible = true;
            back.IsVisible = false;
            _outputTextBlock.IsVisible = true;
            _outputTextBlock1.IsVisible = true;
            _outputTextBlock2.IsVisible = true;
            _outputTextBlock3.IsVisible = true;
            _outputTextBlock4.IsVisible = true;
            _outputTextBlock5.IsVisible = true;
            _outputTextBlock6.IsVisible = true;
            _outputTextBlock7.IsVisible = true;
            _outputTextBlock8.IsVisible = true;
            _outputTextBlock9.IsVisible = true;
            _outputTextBlock10.IsVisible = true;
            _outputTextBlock11.IsVisible = true;
            _outputTextBlock12.IsVisible = true;
            _outputTextBlock13.IsVisible = true;
            _outputTextBlock14.IsVisible = true;
            _outputTextBlock15.IsVisible = true;
            _outputTextBlock16.IsVisible = true;
            _outputTextBlock17.IsVisible = true;
            _outputTextBlock18.IsVisible = true;
            _outputTextBlock19.IsVisible = true;
            _outputTextBlock20.IsVisible = true;
            _outputTextBlock21.IsVisible = true;
            _outputTextBlock22.IsVisible = true;
            _outputTextBlock23.IsVisible = true;
            _outputTextBlock24.IsVisible = true;
            _outputTextBlock25.IsVisible = true;
            _outputTextBlock26.IsVisible = false;
            _outputTextBlock27.IsVisible = false;
            _outputTextBlock28.IsVisible = false;
            _outputTextBlock29.IsVisible = false;
            _outputTextBlock30.IsVisible = false;
            Liver1.IsVisible = false;
            Liver2.IsVisible = false;
            Liver3.IsVisible = false;
            Liver4.IsVisible = false;
            animalsave.IsVisible = false;
            Friend.IsVisible = false;
            Height.IsVisible = false;
            Fur.IsVisible = false;
            Average.IsVisible = false;
            Meal.IsVisible = false;
            Kilo.IsVisible = false;

            _outputTextBlock.Text = "MyAnimal";
            _outputTextBlock1.Text = $"{myAnimal.GetName()}";
            _outputTextBlock2.Text = $"{myAnimal.GetAge()}";
            myAnimal.MakeSound(_outputTextBlock21);
            _outputTextBlock3.Text = "MyWildAnimal";
            _outputTextBlock4.Text = $"{myWildAnimal.GetName()}";
            _outputTextBlock5.Text = $"{myWildAnimal.GetAge()}";
            _outputTextBlock6.Text = $"{myWildAnimal.GetFurColor()}";
            _outputTextBlock7.Text = $"{myWildAnimal.GetAverageAge()}";
            myWildAnimal.MakeSound(_outputTextBlock22);
            _outputTextBlock8.Text = $"MyHomeAnimal";
            _outputTextBlock9.Text = $"{myHomeAnimal.GetName()}";
            _outputTextBlock10.Text = $"{myHomeAnimal.GetAge()}";
            _outputTextBlock11.Text = $"{myHomeAnimal.GetFriendliness()}";
            _outputTextBlock12.Text = $"{myHomeAnimal.GetHeight()}";
            myHomeAnimal.MakeSound(_outputTextBlock23);
            _outputTextBlock13.Text = "MyWildAnimal";
            _outputTextBlock14.Text = $"{myMonkey.GetName()}";
            _outputTextBlock15.Text = $"{myMonkey.GetAge()}";
            _outputTextBlock16.Text = $"{myMonkey.GetFurColor()}";
            _outputTextBlock17.Text = $"{myMonkey.GetAverageAge()}";
            _outputTextBlock18.Text = $"{myMonkey.GetFriendliness()}";
            _outputTextBlock19.Text = $"{myMonkey.GetHeight()}";
            _outputTextBlock20.Text = $"{myMonkey.GetFavoriteMeal()}";
            _outputTextBlock25.Text = $"{myMonkey.GetKilograms()}";
            myWildAnimal.MakeSound(_outputTextBlock24);

            //back = this.FindControl<Button>("Back");
        }


        // Обработчик для первой кнопки
        private void OnFirstButtonClick(object sender, RoutedEventArgs e)
        {
            _inputTextBox.IsVisible = false;
            _outputTextBlock.IsVisible = false;
            fAboutproject.IsVisible = false;
            fexit.IsVisible = false;
            fMyVirtualZOO.IsVisible = false;
            fOurAnimals.IsVisible = false;
            fStart.IsVisible = false;
            tStartperent.IsVisible = false;
            back.IsVisible = true;
            animalsave.IsVisible = false;

            this.Background = new ImageBrush
            {
                Source = new Bitmap("/Users/dagosh/Desktop/Снимок экрана 2024-12-20 в 11.20.38.png"),
                Stretch = Stretch.UniformToFill
            };

            back = this.FindControl<Button>("back");

        }

        // Обработчик для второй кнопки
        private void OnCppButtonClick(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "open";
            process.StartInfo.Arguments = $"-a Terminal ./a.out"; // Запуск a.out в терминале
            process.Start();
        }


        private void OnSecondButtonClick(object sender, RoutedEventArgs e)
        {
            _inputTextBox.IsVisible = false;
            _outputTextBlock.IsVisible = false;
            fAboutproject.IsVisible = false;
            fexit.IsVisible = false;
            fMyVirtualZOO.IsVisible = false;
            fOurAnimals.IsVisible = false;
            fStart.IsVisible = false;
            tStartperent.IsVisible = false;
            back.IsVisible = false;
            Back1.IsVisible = true;
            _outputTextBlock.IsVisible = false;
            _outputTextBlock1.IsVisible = false;
            _outputTextBlock2.IsVisible = false;
            _outputTextBlock3.IsVisible = false;
            _outputTextBlock4.IsVisible = false;
            _outputTextBlock5.IsVisible = false;
            _outputTextBlock6.IsVisible = false;
            _outputTextBlock7.IsVisible = false;
            _outputTextBlock8.IsVisible = false;
            _outputTextBlock9.IsVisible = false;
            _outputTextBlock10.IsVisible = false;
            _outputTextBlock11.IsVisible = false;
            _outputTextBlock12.IsVisible = false;
            _outputTextBlock13.IsVisible = false;
            _outputTextBlock14.IsVisible = false;
            _outputTextBlock15.IsVisible = false;
            _outputTextBlock16.IsVisible = false;
            _outputTextBlock17.IsVisible = false;
            _outputTextBlock18.IsVisible = false;
            _outputTextBlock19.IsVisible = false;
            _outputTextBlock20.IsVisible = false;
            _outputTextBlock21.IsVisible = false;
            _outputTextBlock22.IsVisible = false;
            _outputTextBlock23.IsVisible = false;
            _outputTextBlock24.IsVisible = false;
            _outputTextBlock25.IsVisible = false;
            _outputTextBlock26.IsVisible = true;
            _outputTextBlock27.IsVisible = false;
            _outputTextBlock28.IsVisible = false;
            _outputTextBlock29.IsVisible = false;
            _outputTextBlock30.IsVisible = false;
            Liver1.IsVisible = true;
            Liver2.IsVisible = true;
            Liver3.IsVisible = true;
            Liver4.IsVisible = true;
            animalsave.IsVisible = false;


            _outputTextBlock26.Text = "Choose animal\n to change";
            back = this.FindControl<Button>("Back");
        }
        private void Animal(object sender, RoutedEventArgs e)
        {
            _inputTextBox.IsVisible = false;
            _outputTextBlock.IsVisible = false;
            fAboutproject.IsVisible = false;
            fexit.IsVisible = false;
            fMyVirtualZOO.IsVisible = false;
            fOurAnimals.IsVisible = false;
            fStart.IsVisible = false;
            tStartperent.IsVisible = false;
            back.IsVisible = false;
            Back1.IsVisible = true;
            _outputTextBlock.IsVisible = false;
            _outputTextBlock1.IsVisible = false;
            _outputTextBlock2.IsVisible = false;
            _outputTextBlock3.IsVisible = false;
            _outputTextBlock4.IsVisible = false;
            _outputTextBlock5.IsVisible = false;
            _outputTextBlock6.IsVisible = false;
            _outputTextBlock7.IsVisible = false;
            _outputTextBlock8.IsVisible = false;
            _outputTextBlock9.IsVisible = false;
            _outputTextBlock10.IsVisible = false;
            _outputTextBlock11.IsVisible = false;
            _outputTextBlock12.IsVisible = false;
            _outputTextBlock13.IsVisible = false;
            _outputTextBlock14.IsVisible = false;
            _outputTextBlock15.IsVisible = false;
            _outputTextBlock16.IsVisible = false;
            _outputTextBlock17.IsVisible = false;
            _outputTextBlock18.IsVisible = false;
            _outputTextBlock19.IsVisible = false;
            _outputTextBlock20.IsVisible = false;
            _outputTextBlock21.IsVisible = false;
            _outputTextBlock22.IsVisible = false;
            _outputTextBlock23.IsVisible = false;
            _outputTextBlock24.IsVisible = false;
            _outputTextBlock25.IsVisible = false;
            _outputTextBlock26.IsVisible = false;
            _outputTextBlock27.IsVisible = true;
            _outputTextBlock28.IsVisible = false;
            _outputTextBlock29.IsVisible = false;
            _outputTextBlock30.IsVisible = false;
            Liver1.IsVisible = false;
            Liver2.IsVisible = false;
            Liver3.IsVisible = false;
            Liver4.IsVisible = false;
            Name.IsVisible = true;
            Age.IsVisible = true;
            Friend.IsVisible = false;
            Height.IsVisible = false;
            Fur.IsVisible = false;
            Average.IsVisible = false;
            Meal.IsVisible = false;
            Kilo.IsVisible = false;
            animalsave.IsVisible = true;
            animalsave1.IsVisible = false;
            animalsave2.IsVisible = false;
            animalsave3.IsVisible = false;
            _outputTextBlock27.Text = "Animal";
        }

        private void OnASaveBottom(object sender, RoutedEventArgs e)
        {

            string nameInput = Name.Text;
            string ageInput = Age.Text;
            bool isValid = true;
            int age = 0;
            if (string.IsNullOrEmpty(nameInput) || !Regex.IsMatch(nameInput, @"^[A-Za-z]+$"))
            {
                Name.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Name.BorderBrush = Brushes.Gray;
            }
            if (string.IsNullOrEmpty(ageInput) || !int.TryParse(ageInput, out age) || age < 1 || age > 50)
            {
                Age.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Age.BorderBrush = Brushes.Gray;
            }
            if (isValid)
            {
                myAnimal.Name = nameInput;
                myAnimal.Age = age;
            }
        }

        private void OnASaveBottom1(object sender, RoutedEventArgs e)
        {
            string nameInput = Name.Text;
            string ageInput = Age.Text;
            bool isValid = true;
            int age = 0;
            if (string.IsNullOrEmpty(nameInput) || !Regex.IsMatch(nameInput, @"^[A-Za-z]+$"))
            {
                Name.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Name.BorderBrush = Brushes.Gray;
            }
            if (string.IsNullOrEmpty(ageInput) || !int.TryParse(ageInput, out age) || age < 1 || age > 50)
            {
                Age.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Age.BorderBrush = Brushes.Gray;
            }
            string FriendInput = Friend.Text;
            string HeightInput = Height.Text;
            int frnd = 0;
            int hght = 0;
            if (string.IsNullOrEmpty(FriendInput) || !int.TryParse(FriendInput, out frnd) || frnd < 1 || frnd > 10)
            {
                Friend.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Friend.BorderBrush = Brushes.Gray;
            }
            if (string.IsNullOrEmpty(HeightInput) || !int.TryParse(HeightInput, out hght) || hght < 1 || hght > 200)
            {
                Height.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Height.BorderBrush = Brushes.Gray;
            }
            if (isValid)
            {
                myHomeAnimal.Friendliness = frnd;
                myHomeAnimal.Height = hght;
                myHomeAnimal.Name = nameInput;
                myHomeAnimal.Age = age;
            }
        }

        private void OnASaveBottom2(object sender, RoutedEventArgs e)
        {
            string nameInput = Name.Text;
            string ageInput = Age.Text;
            bool isValid = true;
            int age = 0;
            if (string.IsNullOrEmpty(nameInput) || !Regex.IsMatch(nameInput, @"^[A-Za-z]+$"))
            {
                Name.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Name.BorderBrush = Brushes.Gray;
            }
            if (string.IsNullOrEmpty(ageInput) || !int.TryParse(ageInput, out age) || age < 1 || age > 50)
            {
                Age.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Age.BorderBrush = Brushes.Gray;
            }
            string furInput = Fur.Text;
            string aveInput = Average.Text;
            int ave = 0;
            if (string.IsNullOrEmpty(furInput) || !Regex.IsMatch(furInput, @"^[A-Za-z]+$"))
            {
                Fur.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Fur.BorderBrush = Brushes.Gray;
            }
            if (string.IsNullOrEmpty(aveInput) || !int.TryParse(aveInput, out ave) || ave < 1 || ave > 45)
            {
                Average.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Average.BorderBrush = Brushes.Gray;
            }
            if (isValid)
            {
                myWildAnimal.FurColor = furInput;
                myWildAnimal.AverageAge = ave;
                myWildAnimal.Name = nameInput;
                myWildAnimal.Age = age;
            }
        }

        private void OnASaveBottom3(object sender, RoutedEventArgs e)
        {

            string nameInput = Name.Text;
            string ageInput = Age.Text;
            bool isValid = true;
            int age = 0;
            if (string.IsNullOrEmpty(nameInput) || !Regex.IsMatch(nameInput, @"^[A-Za-z]+$"))
            {
                Name.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Name.BorderBrush = Brushes.Gray;
            }
            if (string.IsNullOrEmpty(ageInput) || !int.TryParse(ageInput, out age) || age < 1 || age > 50)
            {
                Age.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Age.BorderBrush = Brushes.Gray;
            }


            string FriendInput = Friend.Text;
            string HeightInput = Height.Text;
            int frnd = 0;
            int hght = 0;
            if (string.IsNullOrEmpty(FriendInput) || !int.TryParse(FriendInput, out frnd) || frnd < 1 || frnd > 10)
            {
                Friend.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Friend.BorderBrush = Brushes.Gray;
            }
            if (string.IsNullOrEmpty(HeightInput) || !int.TryParse(HeightInput, out hght) || hght < 1 || hght > 200)
            {
                Height.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Height.BorderBrush = Brushes.Gray;
            }
            string furInput = Fur.Text;
            string aveInput = Average.Text;
            int ave = 0;
            if (string.IsNullOrEmpty(furInput) || !Regex.IsMatch(furInput, @"^[A-Za-z]+$"))
            {
                Fur.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Fur.BorderBrush = Brushes.Gray;
            }
            if (string.IsNullOrEmpty(aveInput) || !int.TryParse(aveInput, out ave) || ave < 1 || ave > 45)
            {
                Average.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Average.BorderBrush = Brushes.Gray;
            }
            string mealInput = Meal.Text;
            string kiloInput = Kilo.Text;
            int kilo = 0;
            if (string.IsNullOrEmpty(mealInput) || !Regex.IsMatch(mealInput, @"^[A-Za-z]+$"))
            {
                Meal.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Meal.BorderBrush = Brushes.Gray;
            }
            if (string.IsNullOrEmpty(kiloInput) || !int.TryParse(kiloInput, out kilo) || kilo < 1 || kilo > 50)
            {
                Kilo.BorderBrush = Brushes.Red;
                isValid = false;
            }
            else
            {
                Kilo.BorderBrush = Brushes.Gray;
            }
            if (isValid)
            {
                myMonkey.Name = nameInput;
                myMonkey.Age = age;
                myMonkey.Friendliness = frnd;
                myMonkey.Height = hght;
                myMonkey.FurColor = furInput;
                myMonkey.FavoriteMeal = mealInput;
                myMonkey.Kilograms = kilo;
            }
        }

        private void HomeAnimal(object sender, RoutedEventArgs e)
        {
            _inputTextBox.IsVisible = false;
            _outputTextBlock.IsVisible = false;
            fAboutproject.IsVisible = false;
            fexit.IsVisible = false;
            fMyVirtualZOO.IsVisible = false;
            fOurAnimals.IsVisible = false;
            fStart.IsVisible = false;
            tStartperent.IsVisible = false;
            back.IsVisible = false;
            Back1.IsVisible = true;
            _outputTextBlock.IsVisible = false;
            _outputTextBlock1.IsVisible = false;
            _outputTextBlock2.IsVisible = false;
            _outputTextBlock3.IsVisible = false;
            _outputTextBlock4.IsVisible = false;
            _outputTextBlock5.IsVisible = false;
            _outputTextBlock6.IsVisible = false;
            _outputTextBlock7.IsVisible = false;
            _outputTextBlock8.IsVisible = false;
            _outputTextBlock9.IsVisible = false;
            _outputTextBlock10.IsVisible = false;
            _outputTextBlock11.IsVisible = false;
            _outputTextBlock12.IsVisible = false;
            _outputTextBlock13.IsVisible = false;
            _outputTextBlock14.IsVisible = false;
            _outputTextBlock15.IsVisible = false;
            _outputTextBlock16.IsVisible = false;
            _outputTextBlock17.IsVisible = false;
            _outputTextBlock18.IsVisible = false;
            _outputTextBlock19.IsVisible = false;
            _outputTextBlock20.IsVisible = false;
            _outputTextBlock21.IsVisible = false;
            _outputTextBlock22.IsVisible = false;
            _outputTextBlock23.IsVisible = false;
            _outputTextBlock24.IsVisible = false;
            _outputTextBlock25.IsVisible = false;
            _outputTextBlock26.IsVisible = false;
            _outputTextBlock27.IsVisible = false;
            _outputTextBlock28.IsVisible = true;
            _outputTextBlock29.IsVisible = false;
            _outputTextBlock30.IsVisible = false;
            Liver1.IsVisible = false;
            Liver2.IsVisible = false;
            Liver3.IsVisible = false;
            Liver4.IsVisible = false;
            Name.IsVisible = true;
            Age.IsVisible = true;
            Friend.IsVisible = true;
            Height.IsVisible = true;
            Fur.IsVisible = false;
            Average.IsVisible = false;
            Meal.IsVisible = false;
            Kilo.IsVisible = false;
            animalsave.IsVisible = false;
            animalsave1.IsVisible = true;
            animalsave2.IsVisible = false;
            animalsave3.IsVisible = false;
            _outputTextBlock28.Text = "HomeAnimal";
        }
        private void WildAnimal(object sender, RoutedEventArgs e)
        {
            _inputTextBox.IsVisible = false;
            _outputTextBlock.IsVisible = false;
            fAboutproject.IsVisible = false;
            fexit.IsVisible = false;
            fMyVirtualZOO.IsVisible = false;
            fOurAnimals.IsVisible = false;
            fStart.IsVisible = false;
            tStartperent.IsVisible = false;
            back.IsVisible = false;
            Back1.IsVisible = true;
            _outputTextBlock.IsVisible = false;
            _outputTextBlock1.IsVisible = false;
            _outputTextBlock2.IsVisible = false;
            _outputTextBlock3.IsVisible = false;
            _outputTextBlock4.IsVisible = false;
            _outputTextBlock5.IsVisible = false;
            _outputTextBlock6.IsVisible = false;
            _outputTextBlock7.IsVisible = false;
            _outputTextBlock8.IsVisible = false;
            _outputTextBlock9.IsVisible = false;
            _outputTextBlock10.IsVisible = false;
            _outputTextBlock11.IsVisible = false;
            _outputTextBlock12.IsVisible = false;
            _outputTextBlock13.IsVisible = false;
            _outputTextBlock14.IsVisible = false;
            _outputTextBlock15.IsVisible = false;
            _outputTextBlock16.IsVisible = false;
            _outputTextBlock17.IsVisible = false;
            _outputTextBlock18.IsVisible = false;
            _outputTextBlock19.IsVisible = false;
            _outputTextBlock20.IsVisible = false;
            _outputTextBlock21.IsVisible = false;
            _outputTextBlock22.IsVisible = false;
            _outputTextBlock23.IsVisible = false;
            _outputTextBlock24.IsVisible = false;
            _outputTextBlock25.IsVisible = false;
            _outputTextBlock26.IsVisible = false;
            _outputTextBlock27.IsVisible = true;
            _outputTextBlock28.IsVisible = false;
            _outputTextBlock29.IsVisible = false;
            _outputTextBlock30.IsVisible = false;
            Liver1.IsVisible = false;
            Liver2.IsVisible = false;
            Liver3.IsVisible = false;
            Liver4.IsVisible = false;
            Name.IsVisible = true;
            Age.IsVisible = true;
            Friend.IsVisible = false;
            Height.IsVisible = false;
            Fur.IsVisible = true;
            Average.IsVisible = true;
            Meal.IsVisible = false;
            Kilo.IsVisible = false;
            animalsave.IsVisible = false;
            animalsave1.IsVisible = false;
            animalsave2.IsVisible = true;
            animalsave3.IsVisible = false;
            _outputTextBlock27.Text = "WildAnimal";
        }
        private void Monkey(object sender, RoutedEventArgs e)
        {
            _inputTextBox.IsVisible = false;
            _outputTextBlock.IsVisible = false;
            fAboutproject.IsVisible = false;
            fexit.IsVisible = false;
            fMyVirtualZOO.IsVisible = false;
            fOurAnimals.IsVisible = false;
            fStart.IsVisible = false;
            tStartperent.IsVisible = false;
            back.IsVisible = false;
            Back1.IsVisible = true;
            _outputTextBlock.IsVisible = false;
            _outputTextBlock1.IsVisible = false;
            _outputTextBlock2.IsVisible = false;
            _outputTextBlock3.IsVisible = false;
            _outputTextBlock4.IsVisible = false;
            _outputTextBlock5.IsVisible = false;
            _outputTextBlock6.IsVisible = false;
            _outputTextBlock7.IsVisible = false;
            _outputTextBlock8.IsVisible = false;
            _outputTextBlock9.IsVisible = false;
            _outputTextBlock10.IsVisible = false;
            _outputTextBlock11.IsVisible = false;
            _outputTextBlock12.IsVisible = false;
            _outputTextBlock13.IsVisible = false;
            _outputTextBlock14.IsVisible = false;
            _outputTextBlock15.IsVisible = false;
            _outputTextBlock16.IsVisible = false;
            _outputTextBlock17.IsVisible = false;
            _outputTextBlock18.IsVisible = false;
            _outputTextBlock19.IsVisible = false;
            _outputTextBlock20.IsVisible = false;
            _outputTextBlock21.IsVisible = false;
            _outputTextBlock22.IsVisible = false;
            _outputTextBlock23.IsVisible = false;
            _outputTextBlock24.IsVisible = false;
            _outputTextBlock25.IsVisible = false;
            _outputTextBlock26.IsVisible = false;
            _outputTextBlock27.IsVisible = true;
            _outputTextBlock28.IsVisible = false;
            _outputTextBlock29.IsVisible = false;
            _outputTextBlock30.IsVisible = false;
            Liver1.IsVisible = false;
            Liver2.IsVisible = false;
            Liver3.IsVisible = false;
            Liver4.IsVisible = false;
            Name.IsVisible = true;
            Age.IsVisible = true;
            Friend.IsVisible = true;
            Height.IsVisible = true;
            Fur.IsVisible = true;
            Average.IsVisible = true;
            Meal.IsVisible = true;
            Kilo.IsVisible = true;
            animalsave.IsVisible = false;
            animalsave1.IsVisible = false;
            animalsave2.IsVisible = false;
            animalsave3.IsVisible = true;
            _outputTextBlock27.Text = "Monkey";
        }
    }
}

