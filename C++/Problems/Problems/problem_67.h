#ifndef PROBLEMS_PROBLEM_67_H
#define PROBLEMS_PROBLEM_67_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_67 : public problem {
public:
    bool test() override;

    std::string addBinary(std::string a, std::string b);
};

#endif //PROBLEMS_PROBLEM_67_H