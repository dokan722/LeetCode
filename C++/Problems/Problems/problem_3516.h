#ifndef PROBLEM_3516_H
#define PROBLEM_3516_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_3516 : public problem {
public:
    bool test() override;

    int findClosest(int x, int y, int z) ;
};



#endif //PROBLEM_3516_H
