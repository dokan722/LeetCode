#ifndef PROBLEM_474_H
#define PROBLEM_474_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_474 : public problem {
public:
    bool test() override;

    int findMaxForm(std::vector<std::string>& strs, int m, int n);
};



#endif //PROBLEM_474_H
