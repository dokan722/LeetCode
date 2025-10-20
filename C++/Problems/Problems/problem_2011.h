#ifndef PROBLEM_2011_H
#define PROBLEM_2011_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2011 : public problem {
public:
    bool test() override;

    int finalValueAfterOperations(std::vector<std::string>& operations);
};



#endif //PROBLEM_2011_H
