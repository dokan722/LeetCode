#ifndef PROBLEM_1233_H
#define PROBLEM_1233_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_1233 : public problem {
public:
    bool test() override;

    std::vector<std::string> removeSubfolders(std::vector<std::string>& folder);
};



#endif //PROBLEM_1233_H
