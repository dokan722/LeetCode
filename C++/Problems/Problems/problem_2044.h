#ifndef PROBLEM_2044_H
#define PROBLEM_2044_H

#include "../problem.h"
#include <string>
#include <unordered_map>
#include <vector>

class problem_2044 : public problem {
public:
    bool test() override;

    int countMaxOrSubsets(std::vector<int>& nums);
private:
    void testSubset(int num, int id, std::vector<int>& nums, std::unordered_map<int, int>& counts);
};



#endif //PROBLEM_2044_H
