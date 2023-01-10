namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region tekrar eden harfleri bulma
            Console.WriteLine("Lütfen bir kelime giriniz");
            string a = Console.ReadLine();
            tekrarEdenHarf(a);
           

            #endregion
        }
        #region tekrar eden harfleri bulma metot
        public static string tekrarEdenHarf(string kelime)
        {
            List<char> list = new List<char>();
            for (int i = 0; i < kelime.Length; i++)
            {
                for (int j = i+1; j < kelime.Length; j++)
                {
                    if (kelime[i] == kelime[j])
                    {
                        list.Add(kelime[j]);
                        //if (list[j] == kelime[i])
                        //{
                        //    list.Remove(list[j+1]);
                        //}
                    }
                }
            }
            IEnumerable<char> result = list.Distinct();

            foreach (var item in result)

            {

                Console.WriteLine(item);

            }
            //for (int i = 0; i < result.Count(); i++)
            //{
            //    Console.WriteLine(result[i]);
            //}
            return kelime;
        }
        #endregion
    }
}