#ifndef PROBLEM_771_H
#define PROBLEM_771_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_771 : public problem {
public:
    bool test() override;

    int numJewelsInStones(std::string jewels, std::string stones);
};



#endif //PROBLEM_771_H
