#ifndef PROBLEM_1007_H
#define PROBLEM_1007_H

#include "../problem.h"
#include <vector>

class problem_1007 : public problem {
public:
    bool test() override;

    int minDominoRotations(std::vector<int>& tops, std::vector<int>& bottoms);
};



#endif //PROBLEM_1007_H
