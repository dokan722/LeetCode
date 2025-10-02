#ifndef PROBLEM_48_H
#define PROBLEM_48_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_48 : public problem {
public:
    bool test() override;

    void rotate(std::vector<std::vector<int>>& matrix);
};



#endif //PROBLEM_48_H
