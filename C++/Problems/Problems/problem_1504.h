#ifndef PROBLEM_1504_H
#define PROBLEM_1504_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1504 : public problem {
public:
    bool test() override;

    int numSubmat(std::vector<std::vector<int>>& mat);
};



#endif //PROBLEM_1504_H
