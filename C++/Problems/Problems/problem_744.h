#ifndef PROBLEMS_PROBLEM_744_H
#define PROBLEMS_PROBLEM_744_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_744 : public problem {
public:
    bool test() override;

    char nextGreatestLetter(std::vector<char>& letters, char target);
};

#endif //PROBLEMS_PROBLEM_744_H