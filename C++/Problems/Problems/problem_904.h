#ifndef PROBLEM_904_H
#define PROBLEM_904_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_904 : public problem {
public:
    bool test() override;

    int totalFruit(std::vector<int>& fruits);
};



#endif //PROBLEM_904_H
