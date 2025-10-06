#ifndef PROBLEM_2053_H
#define PROBLEM_2053_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2053 : public problem {
public:
    bool test() override;

    std::string kthDistinct(std::vector<std::string>& arr, int k);
};



#endif //PROBLEM_2053_H
