#ifndef PROBLEM_2657_H
#define PROBLEM_2657_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2657 : public problem {
public:
    bool test() override;

    std::vector<int> findThePrefixCommonArray(std::vector<int>& A, std::vector<int>& B);
};



#endif //PROBLEM_2657_H
