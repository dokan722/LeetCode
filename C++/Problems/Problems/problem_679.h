#ifndef PROBLEM_679_H
#define PROBLEM_679_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_679 : public problem {
public:
    bool test() override;

    bool judgePoint24(std::vector<int>& cards);
private:
    bool judgePoint24Rec(std::vector<double>& cards);
};



#endif //PROBLEM_679_H
