#ifndef PROBLEM_901_H
#define PROBLEM_901_H

#include <stack>

#include "../problem.h"
#include <string>
#include <vector>


class StockSpanner {
public:
    StockSpanner();

    int next(int price);
private:
    std::stack<std::pair<int, int>> _spanStack;
};

class problem_901 : public problem {
public:
    bool test() override;
};



#endif //PROBLEM_901_H
