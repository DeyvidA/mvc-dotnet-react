import {
  FormControl,
  FormErrorMessage,
  FormHelperText,
  FormLabel,
  Input,
  Box,
  Button,
} from "@chakra-ui/react";

const Login = () => {
  return (
    <Box p={4}>
      <form>
        <FormControl id="email">
          <FormLabel>Email address</FormLabel>
          <Input type="email" />
          <FormHelperText>We'll never share your email.</FormHelperText>
        </FormControl>
        <FormControl id="password">
          <FormLabel>Password</FormLabel>
          <Input type="password" />
        </FormControl>
        <Button colorScheme="blue">Submit</Button>
      </form>
    </Box>
  );
};

export default Login;
