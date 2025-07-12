#ifndef PROBLEM_3522_H
#define PROBLEM_3522_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_3522 : public problem {
public:
    bool test() override;

    long long calculateScore(std::vector<std::string>& instructions, std::vector<int>& values);
};



#endif //PROBLEM_3522_H
