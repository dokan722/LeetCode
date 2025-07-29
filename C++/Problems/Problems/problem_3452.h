#ifndef PROBLEM_3452_H
#define PROBLEM_3452_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3452 : public problem {
public:
    bool test() override;

    int sumOfGoodNumbers(std::vector<int>& nums, int k);
private:
    int getNum(int id, std::vector<int>& nums);
};



#endif //PROBLEM_3452_H
