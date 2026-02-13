#ifndef PROBLEMS_PROBLEM_821_H
#define PROBLEMS_PROBLEM_821_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_821 : public problem {
public:
    bool test() override;

    std::vector<int> shortestToChar(std::string s, char c);
};

#endif //PROBLEMS_PROBLEM_821_H