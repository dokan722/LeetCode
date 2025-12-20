#ifndef PROBLEMS_PROBLEM_969_H
#define PROBLEMS_PROBLEM_969_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_969 : public problem {
public:
    bool test() override;

    std::vector<int> pancakeSort(std::vector<int>& arr);
private:
    void flip(int k, std::vector<int>& arr);
};

#endif //PROBLEMS_PROBLEM_969_H