using System;

namespace ConsoleApp1
{
    class Program
    {
        static bool getSword = false;
        static bool toBeHollow = false;
        static void Main(string[] args)
        {
            prologue();
            int option = GetIntInRange(2);
            if (option == 1)
            {
                isShinigami();
                option = GetIntInRange(2);
                if (option == 1)
                {
                    isHollow();
                    option = GetIntInRange(2);
                    if (option == 1)
                    {
                        secEnd();
                    }
                    else if (option == 2)
                    {
                        epilogue();
                    }
                }
                else if (option == 2)
                {
                    netural();
                }
            }
            else if (option == 2)
            {
                firstEnding();
            }
            
        }
        static void netural()
        {
            Console.WriteLine("Ты слишком был измотан");
            Console.ReadLine();
        }
        static void secEnd()
        {
            Console.WriteLine("Пока ты пытался добить своего противника, прибежали еще двое капитанов и тебя окончательно убили.");
            Console.ReadLine();
        }
        static void prologue()
        {
            Console.WriteLine("Тебя зовут Ичиго. Ты можешь видеть духов, в силу своего рождения.");
            Console.ReadLine();
            Console.WriteLine("Одним днем ты увидел душу, отличавщшуюся от других");
            Console.ReadLine();
            Console.WriteLine("Это быыло девушка в черном хаори. Она представилась Рукией - шинигами.");
            Console.ReadLine();
            Console.WriteLine("Шинигами, как она объяснила, тоже духи, но они являются плачами пустых.");
            Console.ReadLine();
            Console.WriteLine("Пустые же это духи которые пожирают души живых.");
            Console.ReadLine();
            Console.WriteLine("И в городе где ты живешь, их полно.");
            Console.ReadLine();
            Console.WriteLine("Раньше ты их не замечал, потому что шинигами быстро с ними справлялись.");
            Console.ReadLine();
            Console.WriteLine("Но в этот раз все было по иному.");
            Console.ReadLine();
            Console.WriteLine("Тут внезапно появляется пустой");
            Console.ReadLine();
            Console.WriteLine("Настолько огромный, что дорожное покрытие покрывалось трещинами при каждом его шаге.");
            Console.ReadLine();
            Console.WriteLine("И вот он разбушешвавшийся сильно ранит Рукию.");
            Console.ReadLine();
            Console.WriteLine("И обессиленная падает на землю.");
            Console.ReadLine();
            Console.WriteLine("Но тут она говорит:");
            Console.ReadLine();
            Console.WriteLine("- Хочешь ли ты спасти себя и свой город от пустых?");
            Console.ReadLine();
            Console.WriteLine("1. Да, конечно.\n2. Нет, я быстро бегаю.");
            
        }
        static void isShinigami()
        {
            Console.WriteLine("- Но для того чтобы убивать пустых, нужно стать шинигами.");
            Console.ReadLine();
            Console.WriteLine("- Готов ли ты жить в двух мирах? В мире живых и в мире духов?");
            Console.ReadLine();
            Console.WriteLine("Ты кивнул ей головой и почувствовал как ее дзампакто проницает в твою грудь.");
            Console.ReadLine();
            Console.WriteLine("*Вспышка*. И ты теперь в таком же хаори.");
            Console.ReadLine();
            Console.WriteLine("У тебя теперь появился свой дзмапакто.");
            Console.ReadLine();
            Console.WriteLine("Но он у тебя во всеь рост, что говорит о огромной силе.");
            Console.ReadLine();
            Console.WriteLine("Ты с легксотью расправляешься с пустым, разбив его белую маску.");
            Console.ReadLine();
            Console.WriteLine("Но тут появляется еще один шинигами.");
            Console.ReadLine();
            Console.WriteLine("Он забирает твою силу шинигами, а Рукия за незаконную передачу реацу, должна будет казнена.");
            Console.ReadLine();
            Console.WriteLine("Будешь ли ты спасасть свою спасительницу?");
            Console.WriteLine("1. Конечно, если у меня получится.\n2. Я и так сильно ранен, куда мне еще.");



        }
        static void firstEnding()
        {
            Console.WriteLine("Ты был слишком пуглив, и поэтому не решился спасать еще и город.");
            Console.ReadLine();
            Console.WriteLine("Ты бежал очень далеко, но все же пустые в разы быстрее обычных людей.");
            Console.ReadLine();
            Console.WriteLine("Тем самым ты стал лишь еще одно жалкой душой для пустого.");
            Console.ReadLine();
            Console.WriteLine("Очень Плохой Конец.");
            Console.ReadLine();
        }
        static void isHollow()
        {
            Console.WriteLine("Ты был растроен, потерян.");
            Console.ReadLine();
            Console.WriteLine("Но тебя нашел один очень мутный тип.");
            Console.ReadLine();
            Console.WriteLine("Он сказал тебе, что силу шинигами можно вернуть.");
            Console.ReadLine();
            Console.WriteLine("- Это очень опасно и может стоить тебе жизни.");
            Console.ReadLine();
            Console.WriteLine("Будешь ли ты рисковать своей жизнью ради нее?");
            Console.ReadLine();
            Console.WriteLine("Ты без доли сомнения соглашаешься.");
            Console.WriteLine("Тебя провоили в очень обширный подвал и начали тренироватью");
            Console.ReadLine();
            Console.WriteLine("тренировка заключалась в том, что к тебе прицепили цепь душ.");
            Console.ReadLine();
            Console.WriteLine("Но это не простая цепь, она саморазъедается.");
            Console.ReadLine();
            Console.WriteLine("И вот бросили тебя в глубокую яму, сказав за 72 часа выбраться из неею");
            Console.ReadLine();
            Console.WriteLine("По истечении этого времени, ты превратишься в пустого.");
            Console.ReadLine();
            Console.WriteLine("Так оно и произошло. Но ты необычный парень.");
            Console.ReadLine();
            Console.WriteLine("Ты стал пустым, но лишь на какую-то часть.");
            Console.ReadLine();
            Console.WriteLine("Таким образом у тебя появился дзампакто.");
            Console.ReadLine();
            Console.WriteLine("И вот тебя отправили в Общество Душ");
            Console.ReadLine();
            Console.WriteLine("И тут тебе встретился очень сильный соперник.");
            Console.ReadLine();
            Console.WriteLine("Вы дрались и оба сильно измотаны.");
            Console.ReadLine();
            Console.WriteLine("Но ты побеждаешь, но ты можешь казнить соперника.");
            Console.WriteLine("1. Казнить.\n2. Пощадить.");
            
        }
        static void epilogue()
        {
            Console.WriteLine("Так как ты решил сохранить ему жизнь, ты успел добежать до темницы и спасти Рукию.");
            Console.ReadLine();
            Console.WriteLine("Happy end.");
            Console.ReadLine();
        }

        static int GetIntInRange(int optionNumber)
        {
            string input = Console.ReadLine();
            int number = -1;
            bool isConverted = int.TryParse(input, out number);
            bool isInRange = number >= 1 && number <= optionNumber;

            while (!isConverted || !isInRange)
            {
                Console.WriteLine("Неверная опция, попробуй ещё раз");
                input = Console.ReadLine();
                isConverted = int.TryParse(input, out number);
                isInRange = number >= 1 && number <= optionNumber;
            }

            return number;
        }
    }
}
