#ifndef PROBLEM_443_H
#define PROBLEM_443_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_443 : public problem {
public:
    bool test() override;

    int compress(std::vector<char>& chars);
};



#endif //PROBLEM_443_H
