#ifndef PROBLEMS_PROBLEM_383_H
#define PROBLEMS_PROBLEM_383_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_383 : public problem {
public:
    bool test() override;

    bool canConstruct(std::string ransomNote, std::string magazine);
};

#endif //PROBLEMS_PROBLEM_383_H