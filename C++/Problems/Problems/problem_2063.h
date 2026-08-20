#ifndef PROBLEMS_PROBLEM_2063_H
#define PROBLEMS_PROBLEM_2063_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_2063 : public problem {
public:
    bool test() override;

    long long countVowels(std::string word);
};

#endif //PROBLEMS_PROBLEM_2063_H