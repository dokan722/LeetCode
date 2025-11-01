#ifndef PROBLEM_3289_H
#define PROBLEM_3289_H


#include "../problem.h"
#include <string>
#include <vector>

class problem_3289 : public problem {
public:
    bool test() override;

    std::vector<int> getSneakyNumbers(std::vector<int>& nums);
};



#endif //PROBLEM_3289_H
