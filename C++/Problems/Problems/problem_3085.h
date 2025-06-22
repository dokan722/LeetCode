#ifndef PROBLEM_3085_H
#define PROBLEM_3085_H


#include "../problem.h"
#include <string>


class problem_3085 : public problem {
public:
    bool test() override;

    int minimumDeletions(std::string word, int k);
};


#endif //PROBLEM_3085_H
