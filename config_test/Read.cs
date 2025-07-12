namespace config_test;

public class Read
{
    public void Picture()
    {            
        string[] lines = File.ReadAllLines("/home/pi/qlocktwo/py/rbg-array.txt");
        bool first = true;
        int xMax, yMax, x, y, red, green, blue;

        foreach (var line in lines)
        {
            if (first)
            {
                first = false;
                xMax = int.Parse(line.Split(';')[1]);
                yMax = int.Parse(line.Split(';')[2]);
                if (xMax != 128 || yMax != 54)
                {
                    throw new Exception("Invalid dimensions");
                }
                continue;
            }
            
            string[] parts = line.Split(',');
            x = int.Parse(parts[0]);
            y = int.Parse(parts[1]);
            red = int.Parse(parts[2]);
            green = int.Parse(parts[3]);
            blue = int.Parse(parts[4]);
            

        }
    }
}