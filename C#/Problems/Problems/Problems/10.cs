using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _10 : IProblem
    {
        public bool Test()
        {
            var s = "abcdede";
            var p = "ab.*de";

            var expected = true;

            var result = IsMatch(s, p);

            return result == expected;

        }

        class MyPair { public char C; public int N; }

        public bool IsMatch(string s, string p)
        {
            var parts = new List<MyPair>();
            var tokens = new List<MyPair>();

            char? prev = null;
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (prev != null &&  prev.Value != s[i])
                {
                    parts.Add(new MyPair{ C = prev.Value, N = count });
                    count = 0;
                }
                prev = s[i];
                count++;
            }
            if (prev != null)
                parts.Add(new MyPair { C = prev.Value, N = count });

            prev = null;
            count = 0;
            var starsSpotted = 0;

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == '*')
                {
                    starsSpotted++;
                    continue;
                }
                if (prev != null && prev.Value != p[i])
                {
                    if (starsSpotted != 0)
                    {
                        count *= -1;
                        count += starsSpotted;
                    }
                    tokens.Add(new MyPair { C = prev.Value, N = count });
                    count = 0;
                    starsSpotted = 0;
                }
                prev = p[i];
                count++;
            }

            if (prev != null)
            {
                if (starsSpotted != 0)
                {
                    count *= -1;
                    count += starsSpotted;
                }
                tokens.Add(new MyPair { C = prev.Value, N = count });
            }

            var partsId = 0;
            var tokensId = 0;

            while (partsId < parts.Count && tokensId < tokens.Count)
            {
                var part = parts[partsId];
                var token = tokens[tokensId];
                if (part.C == token.C)
                {
                    if (token.N > 0)
                    {
                        if (token.N > part.N)
                        {
                            if (part.N == 0)
                                tokensId++;
                            else
                                return false;
                        }
                        else if (token.N < part.N)
                        {
                            part.N -= token.N;
                            tokensId++;
                        }
                        else
                        {
                            tokensId++;
                            partsId++;
                        }
                    }
                    else if (token.N < 0)
                    {
                        var minCount = -token.N;
                        if (part.N < minCount)
                            return false;
                        tokensId++;
                        partsId++;
                    }
                    else
                    {
                        tokensId++;
                        part.N = 0;
                    }
                }
                else if (token.C == '.')
                {
                    if (token.N > 0)
                    {
                        if (token.N > part.N)
                        {
                            token.N -= part.N;
                            partsId++;
                        }
                        else if (token.N < part.N)
                        {
                            part.N -= token.N;
                            tokensId++;
                        }
                        else
                        {
                            tokensId++;
                            partsId++;
                        }
                    }
                    else if (token.N < 0)
                    {
                        var minCount = -token.N;
                        if (part.N < minCount)
                        {
                            token.N += part.N;
                            partsId++;
                        }
                        else
                            return true;
                    }
                    else
                    {
                        while (tokensId < tokens.Count && tokens[tokensId].N == 0)
                            tokensId++;
                        if (tokensId >= tokens.Count)
                            return true;
                        var minCount = tokens[tokensId].N < 0 ? -tokens[tokensId].N : tokens[tokensId].N;
                        while (partsId < parts.Count && (parts[partsId].C != tokens[tokensId].C || parts[partsId].N <= minCount))
                        {
                            if (parts[partsId].C != tokens[tokensId].C)
                                minCount -= parts[partsId].N;
                            partsId++;
                        }
                    }
                }
                else
                {
                    if (token.N == 0)
                    {
                        if (part.N == 0 && partsId + 1 < parts.Count && parts[partsId + 1].C == token.C)
                            partsId++;
                        else
                            tokensId++;
                    }
                    else if (part.N == 0)
                        partsId++;
                    else
                        return false;
                }
            }

            while (tokensId < tokens.Count && tokens[tokensId].N == 0)
                tokensId++;
            while (partsId < parts.Count && parts[partsId].N == 0)
                partsId++;


            return tokensId == tokens.Count && partsId == parts.Count;
        }
    }
}
