using System;
using System.Linq;
public class DryPotatoes
{

    public static double Potatoes(int p0, int w0, int p1)
    {
        double dw = w0 * (100 - p0);
        int fw = (int) dw / (100-p1);
        return fw;
    }
}