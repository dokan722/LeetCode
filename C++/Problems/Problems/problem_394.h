#ifndef PROBLEM_394_H
#define PROBLEM_394_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_394 : public problem {
public:
    bool test() override;

    std::string decodeString(std::string s);
private:
    std::string decode(std::string s, int &i);
};

#endif //PROBLEM_394_H
