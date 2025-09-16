#ifndef PROBLEM_2640_H
#define PROBLEM_2640_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2640 : public problem {
public:
    bool test() override;

    std::vector<long long> findPrefixScore(std::vector<int>& nums);
};



#endif //PROBLEM_2640_H
