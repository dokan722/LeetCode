//
// Created by peite on 24.06.2025.
//

#ifndef PROBLEM_2200_H
#define PROBLEM_2200_H



#include "../problem.h"
#include <vector>


class problem_2200 : public problem {
public:
    bool test() override;

    std::vector<int> findKDistantIndices(std::vector<int>& nums, int key, int k);
};




#endif //PROBLEM_2200_H
