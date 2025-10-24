#ifndef PROBLEM_2048_H
#define PROBLEM_2048_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2048 : public problem {
public:
    bool test() override;

    int nextBeautifulNumber(int n);
};



#endif //PROBLEM_2048_H
