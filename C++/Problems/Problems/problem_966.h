#ifndef PROBLEM_966_H
#define PROBLEM_966_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_966 : public problem {
public:
    bool test() override;

    std::vector<std::string> spellchecker(std::vector<std::string>& wordlist, std::vector<std::string>& queries);
private:
    std::string wildcardVowels(std::string word);
};



#endif //PROBLEM_966_H
