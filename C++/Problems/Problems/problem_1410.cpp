#include "problem_1410.h"

#include <unordered_map>

bool problem_1410::test() {
    std::string text = "&amp; is an HTML entity but &ambassador; is not.";

    std::string expected = "& is an HTML entity but &ambassador; is not.";

    auto result = entityParser(text);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_1410::entityParser(std::string text) {
    std::unordered_map<std::string, std::string> encoded
    {
            {"quot", "\""},
            {"apos", "\'"},
            {"amp", "&"},
            {"gt", ">"},
            {"lt", "<"},
            {"frasl", "/"}
    };
    int n = text.size();
    std::string result = "";
    for (int i = 0; i < n; ++i)
    {
        if (text[i] == '&' && i != n - 1)
        {
            int start = i;
            i++;
            while (i < n && text[i] != ';' && text[i] != '&')
                i++;
            if (i == n)
                result += text.substr(start);
            else if (text[i] == '&')
            {
                result += text.substr(start, i - start);
                i--;
            }
            else
            {
                auto ins = text.substr(start + 1, i - start - 1);
                if (encoded.contains(ins))
                    result += encoded[ins];
                else
                    result += text.substr(start, i - start + 1);
            }
        }
        else
            result += text[i];
    }
    return result;
}
