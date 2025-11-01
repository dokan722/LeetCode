#ifndef PROBLEM_763_H
#define PROBLEM_763_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_763 : public problem {
public:
    bool test() override;

    std::vector<int> partitionLabels(std::string s);
};



#endif //PROBLEM_763_H
