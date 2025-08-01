#ifndef PROBLEM_898_H
#define PROBLEM_898_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_898 : public problem {
public:
    bool test() override;

    int subarrayBitwiseORs(std::vector<int>& arr);
};



#endif //PROBLEM_898_H
