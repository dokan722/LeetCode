#ifndef PROBLEM_1839_H
#define PROBLEM_1839_H

#include "../problem.h"
#include <string>

class problem_1839 : public problem {
public:
    bool test() override;

    int longestBeautifulSubstring(std::string word);
};



#endif //PROBLEM_1839_H
