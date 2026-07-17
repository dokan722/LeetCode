#ifndef PROBLEM_1333_H
#define PROBLEM_1333_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_1333 : public problem {
public:
    bool test() override;

    std::vector<int> filterRestaurants(std::vector<std::vector<int>>& restaurants, int veganFriendly, int maxPrice, int maxDistance) ;
};

#endif //PROBLEM_1333_H
