#ifndef PROBLEM_2211_H
#define PROBLEM_2211_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2211 : public problem {
public:
    bool test() override;

    int countCollisions(std::string directions);
};

#endif //PROBLEM_2211_H
