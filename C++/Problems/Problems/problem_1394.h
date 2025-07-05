#ifndef PROBLEM_1394_H
#define PROBLEM_1394_H

#include "../problem.h"
#include <vector>

class problem_1394 : public problem {
public:
    bool test() override;

    int findLucky(std::vector<int>& arr);
};



#endif //PROBLEM_1394_H
