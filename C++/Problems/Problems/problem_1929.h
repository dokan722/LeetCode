#ifndef PROBLEM_1929_H
#define PROBLEM_1929_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1929 : public problem {
public:
    bool test() override;

    std::vector<int> getConcatenation(std::vector<int>& nums);
};



#endif //PROBLEM_1929_H
