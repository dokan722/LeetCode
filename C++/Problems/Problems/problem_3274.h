#ifndef PROBLEM_3274_H
#define PROBLEM_3274_H


#include "../problem.h"
#include <string>
#include <vector>

class problem_3274: public problem {
public:
    bool test() override;

    bool checkTwoChessboards(std::string coordinate1, std::string coordinate2);
};



#endif //PROBLEM_3274_H
