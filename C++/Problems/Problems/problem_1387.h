#ifndef PROBLEM_1387_H
#define PROBLEM_1387_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1387 : public problem {
public:
    bool test() override;

    int getKth(int lo, int hi, int k);
    int getPower(int n, std::vector<int>& pows);
};



#endif //PROBLEM_1387_H
