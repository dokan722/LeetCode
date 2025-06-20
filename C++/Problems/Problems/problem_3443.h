#ifndef PROBLEM_3443_H
#define PROBLEM_3443_H

#include "../problem.h"
#include <string>


class problem_3443 : public problem {
public:
    bool test() override;

    int maxDistance(std::string s, int k);
};



#endif //PROBLEM_3443_H
