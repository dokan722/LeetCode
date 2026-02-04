#ifndef PROBLEM_2957_H
#define PROBLEM_2957_H


#include "../problem.h"
#include <string>
#include <vector>

class problem_2957 : public problem {
public:
    bool test() override;

    int removeAlmostEqualCharacters(std::string word);
};

#endif //PROBLEM_2957_H
