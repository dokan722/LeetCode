#ifndef PROBLEM_2438_H
#define PROBLEM_2438_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2438 : public problem {
public:
    bool test() override;

    std::vector<int> productQueries(int n, std::vector<std::vector<int>>& queries);
private:
    std::vector<int> getProblemArray(int n);
    std::vector<int> transformToBitArray(int num);
};



#endif //PROBLEM_2438_H
