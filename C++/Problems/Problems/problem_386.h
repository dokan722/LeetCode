#ifndef PROBLEM_386_H
#define PROBLEM_386_H

#include "../problem.h"

#include <vector>

class problem_386 : public problem
{
public:
    bool test() override;

    std::vector<int> lexicalOrder(int n);
private:
    void lexicalOrderRec(int n, int num, std::vector<int>* result);
};



#endif //PROBLEM_386_H
