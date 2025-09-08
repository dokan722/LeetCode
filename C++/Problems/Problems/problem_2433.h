#ifndef PROBLEM_2433_H
#define PROBLEM_2433_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2433 : public problem {
public:
    bool test() override;

    std::vector<int> findArray(std::vector<int>& pref);
};



#endif //PROBLEM_2433_H
