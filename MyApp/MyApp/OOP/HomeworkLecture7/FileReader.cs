namespace MyApp.OOP.HomeworkLecture7
{
    public class FileReader
    {
        //C:\Users\AtanasAtanasov\source\repos\MyApp\MyApp\OOP\HomeworkLecture7\mockupFile.txt
        public static void ReadFile(string filePath)
        {

            try
            {
                Console.WriteLine("File content using ReadAllLines");
                foreach (string line in File.ReadAllLines(filePath))
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ReadFileWithStreamer(string filePath)
        {
            StreamReader reader = null;
            try
            {
                Console.WriteLine("File content using StreamReader");
                reader = new StreamReader(filePath);
                string fileContent = reader.ReadToEnd();
                Console.WriteLine(fileContent);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
