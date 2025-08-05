#ifndef PROBLEM3477_H
#define PROBLEM3477_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3477 : public problem {
public:
    bool test() override;

    int numOfUnplacedFruits(std::vector<int>& fruits, std::vector<int>& baskets);
};



#endif //PROBLEM3477_H
