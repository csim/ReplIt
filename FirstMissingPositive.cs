using System;
using System.Collections.Generic;

public class FirstMissingPositive
{
	public static void Test()
	{
        var i = Find(new[] { 4,-1,1,3,0 });

        Console.WriteLine(i);
	}

    public static int Find(int[] nums) {
        var iset = new HashSet<int>();
        
        var ret = 100000;

        foreach (var i in nums) iset.Add(i);

        foreach (var i in nums) {
            var ip = i + 1;
            var im = i - 1;

            if (!iset.Contains(im) && im < ret && im > 0) {
                ret = im;
            } else if (!iset.Contains(ip) && ip < ret && ip > 0) {
                ret = ip;
                continue;
            }
        }

        return ret;
    }
}
