#ifndef PROBLEM_825_H
#define PROBLEM_825_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_825 : public problem {
public:
    bool test() override;

    int numFriendRequests(std::vector<int>& ages);
};



#endif //PROBLEM_825_H
