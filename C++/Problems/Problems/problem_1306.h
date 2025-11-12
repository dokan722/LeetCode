#ifndef PROBLEM_1306_H
#define PROBLEM_1306_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1306 : public problem {
public:
    bool test() override;

    bool canReach(std::vector<int>& arr, int start);
};



#endif //PROBLEM_1306_H
