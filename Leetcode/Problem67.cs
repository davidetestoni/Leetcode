using System.Text;

namespace Leetcode;

public static class Problem67
{
    public static string AddBinary(string a, string b)
    {
        if (a.Length > b.Length)
        {
            b = b.PadLeft(a.Length, '0');
        }
        else if (a.Length < b.Length)
        {
            a = a.PadLeft(b.Length, '0');
        }

        var sb = new StringBuilder();
        var carry = false;

        for (int i = a.Length - 1; i >= 0; i--)
        {
            if (carry)
            {
                // 1 + 1 w/ carry = 1 w/ carry
                if (a[i] == '1' && b[i] == '1')
                {
                    sb.Insert(0, '1');
                }
                // 0 + 0 w/ carry = 1 w/o carry
                else if (a[i] == '0' && b[i] == '0')
                {
                    carry = false;
                    sb.Insert(0, '1');
                }
                // 1 + 0 w/ carry = 0 w/ carry
                else
                {
                    sb.Insert(0, '0');
                }
            }
            else
            {
                // 1 + 1 w/o carry = 0 w/ carry
                if (a[i] == '1' && b[i] == '1')
                {
                    carry = true;
                    sb.Insert(0, '0');
                }
                // 0 + 0 w/o carry = 0 w/o carry
                else if (a[i] == '0' && b[i] == '0')
                {
                    sb.Insert(0, '0');
                }
                // 1 + 0 w/o carry = 1 w/o carry
                else
                {
                    sb.Insert(0, '1');
                }
            }
        }

        if (carry)
        {
            sb.Insert(0, '1');
        }

        return sb.ToString();
    }
}
