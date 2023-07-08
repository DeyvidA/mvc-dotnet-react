import { Box, Flex, Heading, Text, Button } from "@chakra-ui/react";

const HomePage = () => {
  alert("HomePage.js");
  return (
    <Box p={4}>
      <Flex justifyContent="space-between" alignItems="center" mb={8}>
        <Heading as="h1" size="xl">
          Sistema de Gestión Bibliotecaria
        </Heading>
        <Button colorScheme="blue">Iniciar sesión</Button>
      </Flex>

      <Box>
        <Text fontSize="xl" mb={4}>
          ¡Bienvenido a nuestra biblioteca!
        </Text>

        <Text>
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec
          elementum semper nibh, vitae condimentum urna malesuada id. Sed nec
          nisl massa. Nulla convallis, neque a gravida interdum, nisi tortor
          luctus nulla, sit amet dapibus nunc mi id lacus.
        </Text>
      </Box>
    </Box>
  );
};

export default HomePage;
