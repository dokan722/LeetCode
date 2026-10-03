#ifndef PROBLEMS_PROBLEM_22_H
#define PROBLEMS_PROBLEM_22_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_22 : public problem {
public:
    bool test() override;

    std::vector<std::string> generateParenthesis(int n);
private:
    void generateRec(std::vector<std::string>& result, std::string cur, int d, int l);
};

#endif //PROBLEMS_PROBLEM_22_H